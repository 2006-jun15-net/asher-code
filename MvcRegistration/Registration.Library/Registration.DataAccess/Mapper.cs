using AutoMapper;
using System;
using System.Linq;

namespace Registration.DataAccess
{
    public static class Mapper
    {
        public static Library.Models.Student MapStudentEntity(Entities.Student student)
        {
            var config = new MapperConfiguration(cfg =>
            { cfg.CreateMap<Entities.Student, Library.Models.Student>(); }
            );
            IMapper mapper = config.CreateMapper();

            // Map<Source Model, Destination Model>(source)
            return mapper.Map<Entities.Student, Library.Models.Student>(student);

            // Alternate way to do without using automapper
            /*
            return new Library.Models.Student
            {
                Id = student.StudentId,
                FirstName = student.FirstName,
                LastName = student.LastName
            };
            */
        }

        public static Entities.Student MapStudentModel(Library.Models.Student student)
        {
            var config = new MapperConfiguration(cfg =>
            { cfg.CreateMap<Library.Models.Student, Entities.Student>(); }
            );
            IMapper mapper = config.CreateMapper();

            return mapper.Map<Library.Models.Student, Entities.Student>(student);

            // Alternate way to do without using automapper
            /*
            return new Entities.Student
            {
                StudentId = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName
            };
            */
        }

        public static Library.Models.Score MapScoreEntity(Entities.Score score)
        {
            var config = new MapperConfiguration(cfg =>
            { cfg.CreateMap<Entities.Score, Library.Models.Score>(); }
            );
            IMapper mapper = config.CreateMapper();

            return mapper.Map<Entities.Score, Library.Models.Score>(score);
        }

        public static Entities.Score MapScoreModel(Library.Models.Score score)
        {
            var config = new MapperConfiguration(cfg =>
            { cfg.CreateMap<Library.Models.Score, Entities.Score>(); }
            );
            IMapper mapper = config.CreateMapper();

            return mapper.Map<Library.Models.Score, Entities.Score>(score);
        }

        public static Library.Models.Subject MapSubjectEntity(Entities.Subject subject)
        {
            var config = new MapperConfiguration(cfg =>
            { cfg.CreateMap<Entities.Subject, Library.Models.Subject>(); }
            );
            IMapper mapper = config.CreateMapper();

            return mapper.Map<Entities.Subject, Library.Models.Subject>(subject);
        }

        public static Entities.Subject MapSubjectModel(Library.Models.Subject subject)
        {
            var config = new MapperConfiguration(cfg =>
            { cfg.CreateMap<Library.Models.Subject, Entities.Subject>(); }
            );
            IMapper mapper = config.CreateMapper();

            return mapper.Map<Library.Models.Subject, Entities.Subject>(subject);
        }
    }
}
