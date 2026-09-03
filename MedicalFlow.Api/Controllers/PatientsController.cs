using System.Collections.Generic;
using System.Linq;
using DevExpress.Xpo;
using MedicalFlow.Domain.Dtos;
using MedicalFlow.Infrastructure.Xpo;
using MedicalFlow.Infrastructure.Xpo.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MedicalFlow.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<PatientDto>> GetAll()
        {
            using (var unitOfWord = XpoConnectionHelper.CreateUnitOfWork())
            {
                // Mapowanie encji XPO na lekkie obiekty DTO do wysyłki przez HTTP
                var patients = new XPQuery<Patient>(unitOfWord)
                    .Select(p => new PatientDto
                    {
                        Id = p.Oid,
                        FirstName = p.FirstName,
                        LastName = p.LastName,
                        Pesel = p.Pesel,
                        PhoneNumber = p.PhoneNumber
                    })
                    .ToList();

                return Ok(patients);
            }
        }

        [HttpPost]
        public ActionResult<PatientDto> Create([FromBody] CreateOrUpdatePatientDto dto)
        {
            using (var unitOfWord = XpoConnectionHelper.CreateUnitOfWork())
            {
                var patient = new Patient(unitOfWord)
                {
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    Pesel = dto.Pesel,
                    PhoneNumber = dto.PhoneNumber
                };

                unitOfWord.CommitChanges(); // Zapis nowego rekordu w bazie

                return Ok(new PatientDto
                {
                    Id = patient.Oid,
                    FirstName = patient.FirstName,
                    LastName = patient.LastName,
                    Pesel = patient.Pesel,
                    PhoneNumber = patient.PhoneNumber
                });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using (var unitOfWork = XpoConnectionHelper.CreateUnitOfWork())
            {
                var patient = unitOfWork.GetObjectByKey<Patient>(id);
                if (patient == null) return NotFound();

                patient.Delete();
                unitOfWork.CommitChanges();
                return NoContent();
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] CreateOrUpdatePatientDto dto)
        {
            using (var unitOfWork = XpoConnectionHelper.CreateUnitOfWork())
            {
                var patient = unitOfWork.GetObjectByKey<Patient>(id);
                if (patient == null) return NotFound();

                // Przepisanie zaktualizowanych danych z DTO do encji bazodanowej
                patient.FirstName = dto.FirstName;
                patient.LastName = dto.LastName;
                patient.Pesel = dto.Pesel;
                patient.PhoneNumber = dto.PhoneNumber;

                unitOfWork.CommitChanges(); // Zapisanie zmian w bazie MS SQL
                return NoContent();
            }
        }
    }
}