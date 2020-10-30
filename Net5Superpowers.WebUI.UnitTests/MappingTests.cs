using AutoMapper;
using Net5Superpowers.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Net5Superpowers.WebUI.UnitTests
{
    public class MappingTests
    {
        private IMapper _mapper;

        public MappingTests()
        {
            var configurationProvider = new MapperConfiguration(configure =>
            {
                configure.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public void ShouldHaveValidConfiguration()
        {
            _mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }

        [Theory]
        [InlineData(typeof(TodoList), typeof(TodoListDto))]
        [InlineData(typeof(TodoItem), typeof(TodoItemDto))]
        public void ShouldSupportKnownTypeMapping(Type source, Type destination)
        {
            var instance = Activator.CreateInstance(source);

            _mapper.Map(instance, source, destination);
        }
    }
}
