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
            IList<ViewStudentDto> list = new List<ViewStudentDto>();

            list.Add(new ViewStudentDto
            {
                Id = StudentId.New(),
                Name = "Boris",
                WhenEnrolled = new DateTime(2018, 08, 30)

            });

            list.Add(new ViewStudentDto
            {
                Id = StudentId.New(),
                Name = "Katharina",
                WhenEnrolled = new DateTime(2019, 09, 3)

            });

            list.Add(new ViewStudentDto
            {
                Id = StudentId.New(),
                Name = "Erika",
                WhenEnrolled = new DateTime(2018, 08, 28)

            });

            list.Add(new ViewStudentDto
            {
                Id = StudentId.New(),
                Name = "Sergei",
                WhenEnrolled = new DateTime(2019, 10, 1)

            });

            return list;
        }
    }
}
