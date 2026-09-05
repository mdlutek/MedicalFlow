# 🏥 MedicalFlow

System do zarządzania przychodnią lekarską, obsługi wizyt oraz kolejki pacjentów.

Projekt został zaprojektowany jako referencyjny przykład połączenia **Clean Architecture**, **Domain-Driven Design (DDD)** oraz wzorca **MVVM w Windows Forms**. System wykorzystuje fizyczny podział na **3 warstwy (3-Tier Architecture)**, z aplikacją desktopową komunikującą się z backendem poprzez REST API uruchomione w kontenerze Docker.

---

## 🏛️ Architektura rozwiązania

MedicalFlow wykorzystuje **3-Tier Architecture** jako fizyczny podział systemu oraz **Clean Architecture / DDD** do organizacji odpowiedzialności wewnątrz poszczególnych warstw.

### 3-Tier Architecture

```text
┌─────────────────────────────────────────────────────────┐
│ TIER 1 — PRESENTATION                                   │
│                                                         │
│ MedicalFlow.WinForms                                   │
│ .NET Framework 4.7.2 + DevExpress + MVVM               │
│                                                         │
│ Interfejs użytkownika, ViewModels, nawigacja            │
└──────────────────────────┬──────────────────────────────┘
                           │
                       HTTP / JSON
                           │
┌──────────────────────────▼──────────────────────────────┐
│ TIER 2 — APPLICATION / BUSINESS                         │
│                                                         │
│ MedicalFlow.Api                                        │
│ MedicalFlow.Application                                │
│ MedicalFlow.Domain                                     │
│                                                         │
│ REST API, przypadki użycia i logika biznesowa           │
└──────────────────────────┬──────────────────────────────┘
                           │
                    Repository / ORM
                           │
┌──────────────────────────▼──────────────────────────────┐
│ TIER 3 — DATA                                           │
│                                                         │
│ MedicalFlow.Infrastructure.Xpo                         │
│ DevExpress XPO                                         │
│ Microsoft SQL Server                                   │
│                                                         │
│ Persistencja i dostęp do danych                         │
└─────────────────────────────────────────────────────────┘
```

### Podział projektów

| Tier           | Projekt                          | Odpowiedzialność                                            |
| :------------- | :------------------------------- | :---------------------------------------------------------- |
| **Tier 1**     | `MedicalFlow.WinForms`           | Interfejs użytkownika, MVVM, nawigacja i komunikacja z API  |
| **Tier 2**     | `MedicalFlow.Api`                | REST API, HTTP, kontrolery i obsługa żądań                  |
| **Tier 2**     | `MedicalFlow.Application`        | Przypadki użycia aplikacji i abstrakcje dostępu do danych   |
| **Tier 2**     | `MedicalFlow.Domain`             | Encje, Value Objects, enumy i reguły biznesowe              |
| **Tier 3**     | `MedicalFlow.Infrastructure.Xpo` | Implementacja repozytoriów, XPO i persistencja              |
| **Tier 3**     | `SQL Server`                     | Trwałe przechowywanie danych                                |
| **Cross-Tier** | `MedicalFlow.Contracts`          | DTO i kontrakty danych wymienianych pomiędzy klientem i API |

> `MedicalFlow.Contracts` nie stanowi osobnego Tieru. Jest współdzieloną biblioteką definiującą kontrakt komunikacyjny pomiędzy aplikacją WinForms i Web API.

---

## 🧩 Struktura rozwiązania

### `MedicalFlow.Domain` — model domenowy

Najbardziej niezależna część systemu, zawierająca pojęcia i reguły biznesowe związane z działalnością przychodni.

* Encje domenowe:

  * `Patient`
  * `Doctor`
  * `Visit`
  * `QueueTicket`
* Value Objects:

  * `Pesel`
* Enumy domenowe:

  * `VisitStatus`
* Reguły i zachowania biznesowe enkapsulowane w modelu domenowym.
* Brak zależności od XPO, SQL Server, ASP.NET Core, WinForms czy DevExpress.

**Odpowiada na pytanie:**

> *Jakie pojęcia i reguły biznesowe obowiązują w systemie?*

---

### `MedicalFlow.Application` — przypadki użycia

Warstwa odpowiedzialna za realizację operacji wykonywanych przez system.

Docelowo obejmuje przypadki użycia takie jak:

* pobieranie pacjentów,
* tworzenie pacjenta,
* aktualizacja danych,
* usuwanie pacjenta,
* umawianie wizyt,
* zmiana statusu wizyty,
* obsługa kolejki pacjentów.

Zawiera również abstrakcje dostępu do danych:

* `IPatientRepository`
* `IDoctorRepository`
* `IVisitRepository`
* `IQueueTicketRepository`

Application korzysta z modelu domenowego, ale nie zna szczegółów technicznych jego przechowywania.

**Odpowiada na pytanie:**

> *Co system ma zrobić w odpowiedzi na operację użytkownika?*

---

### `MedicalFlow.Contracts` — kontrakty komunikacyjne

Zawiera modele danych wymieniane pomiędzy aplikacją desktopową i Web API.

Przykładowe DTO:

* `PatientDto`
* `CreateOrUpdatePatientDto`
* `DashboardStatsDto`
* `HealthDto`

Modele są niezależne od encji domenowych i modeli persystencji.

Przykładowy przepływ:

```text
WinForms
    │
    │ HTTP / JSON
    ▼
MedicalFlow.Api
    │
    ▼
Contracts / DTO
```

**Odpowiada na pytanie:**

> *Jakie dane są przesyłane pomiędzy klientem a serwerem?*

---

### `MedicalFlow.Infrastructure.Xpo` — infrastruktura i persystencja

Warstwa odpowiedzialna za techniczną realizację dostępu do danych.

Zawiera:

* encje persystencji `*Entity`,
* implementacje repozytoriów,
* konfigurację DevExpress XPO,
* `UnitOfWork`,
* `ThreadSafeDataLayer`,
* mapowanie pomiędzy modelami XPO i encjami domenowymi.

Przykładowy przepływ:

```text
Application
     │
     │ IPatientRepository
     ▼
PatientRepository
     │
     ▼
DevExpress XPO
     │
     ▼
SQL Server
```

Application nie musi wiedzieć, czy dane są przechowywane przez XPO, Dapper czy inne rozwiązanie.

**Odpowiada na pytanie:**

> *W jaki techniczny sposób realizujemy dostęp do danych?*

---

### `MedicalFlow.Api` — backend

Backend systemu zbudowany w oparciu o **ASP.NET Core Web API (.NET 8)**.

Odpowiada za:

* komunikację HTTP,
* endpointy REST,
* kontrolery,
* walidację i obsługę żądań,
* serializację JSON,
* integrację z warstwą Application,
* Health Check,
* dokumentację API poprzez Swagger.

Przykładowe endpointy:

```text
GET    /api/patients
POST   /api/patients
PUT    /api/patients/{id}
DELETE /api/patients/{id}

GET    /api/health
```

API uruchamiane jest w kontenerze **Docker Linux**.

---

### `MedicalFlow.WinForms` — aplikacja kliencka

Desktopowa aplikacja użytkownika zbudowana w oparciu o:

* .NET Framework 4.7.2,
* Windows Forms,
* DevExpress,
* MVVM,
* `Microsoft.Extensions.DependencyInjection`.

Zawiera:

* Views,
* ViewModels,
* nawigację,
* komunikację z Web API,
* obsługę interakcji użytkownika.

Komunikacja z backendem odbywa się poprzez `IPatientApiClient` i REST API.

Aplikacja desktopowa **nie posiada bezpośredniego dostępu do SQL Server**.

---

## 🛠️ Stos technologiczny

| Obszar                   | Technologie                                              |
| :----------------------- | :------------------------------------------------------- |
| **Frontend / Desktop**   | .NET Framework 4.7.2, WinForms, DevExpress               |
| **Architektura UI**      | MVVM, DevExpress MVVM                                    |
| **Backend**              | .NET 8, ASP.NET Core Web API, Kestrel                    |
| **Kontrakty**            | .NET Standard 2.0, DTO                                   |
| **Baza danych**          | Microsoft SQL Server                                     |
| **ORM**                  | DevExpress XPO                                           |
| **Dostęp do danych**     | Repository Pattern, XPO                                  |
| **Dependency Injection** | Microsoft.Extensions.DependencyInjection                 |
| **Konteneryzacja**       | Docker Desktop, Linux / WSL 2                            |
| **API Documentation**    | Swagger / OpenAPI                                        |
| **Wzorce i podejścia**   | Clean Architecture, DDD, SOLID, Repository Pattern, MVVM |

---

## 🚀 Szybki start

### Krok 1: Uruchomienie API w Dockerze

W głównym katalogu projektu uruchom terminal:

```bash
# Zbudowanie obrazu
docker build -t medicalflow-api -f MedicalFlow.Api/Dockerfile .

# Uruchomienie kontenera
docker run -d -p 8080:8080 \
  -e ASPNETCORE_ENVIRONMENT=Development \
  --name medicalflow-app \
  medicalflow-api
```

API będzie dostępne pod:

```text
http://localhost:8080
```

Dokumentacja Swagger:

```text
http://localhost:8080/swagger
```

### Krok 2: Uruchomienie aplikacji WinForms

1. Otwórz `MedicalFlow.slnx` w Visual Studio.
2. Ustaw `MedicalFlow.WinForms` jako projekt startowy.
3. Uruchom aplikację przyciskiem `F5`.
