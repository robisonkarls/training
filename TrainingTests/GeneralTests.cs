using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TrainingTests
{
    public class GeneralTests
    {
        [Test]
        public void Test()
        {
            var dtos = new[]
            {
                new Dto { Title = "test", Id = 1, Value = 1 },
                new Dto { Title = "test", Id = 1, Value = 2 },
                new Dto { Title = "test", Id = 1, Value = 3 },
                new Dto { Title = "test", Id = 1, Value = 4 },
                new Dto { Title = "test", Id = 1, Value = 5 },
            };

            var ditos = dtos
                .GroupBy(d => new
                {
                    Id = d.Id,
                    Title = d.Title
                })
                .Select((x) => new Dtos
                {
                    Id = x.Key.Id,
                    Title = x.Key.Title,
                    Values = x.Select(d => d.Value)
                });
            
            Assert.IsNotEmpty(ditos);

        }
    }

    internal class Dto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Value { get; set; }
    }

    internal class Dtos
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public IEnumerable<int> Values { get; set; }
    }
}