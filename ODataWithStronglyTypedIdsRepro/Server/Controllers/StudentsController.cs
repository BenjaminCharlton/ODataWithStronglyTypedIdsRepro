using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ODataWithStronglyTypedIdsRepro.Shared;
using ODataWithStronglyTypedIdsRepro.Shared.ValueObjects;
using System;
using System.Collections.Generic;

namespace ODataWithStronglyTypedIdsRepro.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly ILogger<StudentsController> _logger;

        public StudentsController(ILogger<StudentsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [EnableQuery]
        public IEnumerable<ViewStudentDto> Get()
        {
            /* In reality, the controller will get this list from the service tier, and the service
             * tier will get it from the data tier, and the data tier (which will be entity framework)
             will get it from the database. All that is too complex to reproduce in this sample app
             so I'm just going to hard code the list here. */
            IList<ViewStudentDto> list = new List<ViewStudentDto>();

            list.Add(new ViewStudentDto
            {
                Id = new StudentId(new Guid("54c361f2-6e83-4b1e-9dd1-badb736bb493")),
                Name = "Boris",
                WhenEnrolled = new DateTime(2018, 08, 30)

            });

            list.Add(new ViewStudentDto
            {
                Id = new StudentId(new Guid("66159e11-97ae-4be7-894d-a1165dd5e5eb")),
                Name = "Katharina",
                WhenEnrolled = new DateTime(2019, 09, 3)

            });

            list.Add(new ViewStudentDto
            {
                Id = new StudentId(new Guid("16417233-daef-4a0f-ac4a-b72a1dbdf2eb")),
                Name = "Erika",
                WhenEnrolled = new DateTime(2018, 08, 28)

            });

            list.Add(new ViewStudentDto
            {
                Id = new StudentId(new Guid("83647ea9-f063-4707-ab97-4b881cae4822")),
                Name = "Sergei",
                WhenEnrolled = new DateTime(2019, 10, 1)

            });

            return list;
        }
    }
}
