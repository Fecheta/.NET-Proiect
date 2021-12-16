using Application.Features.Commands;
using AutoFixture;
using FluentAssertions;
using FluentValidation.TestHelper;
using NUnit.Framework;

namespace Tests.Controllers.Validators
{
    [TestFixture]
    public class CreateHouseCommandValidatorTests
    {
        private CreateHouseCommandValidator _validator;
        private IFixture _fixture;

        [SetUp]
        public void Init()
        {
            _validator = new CreateHouseCommandValidator();
            _fixture = new Fixture();
        }

        [Test]
        public void WhenRequestIsOk_ShouldReturnTrue()
        {
            var model = _fixture.Build<CreateHouseCommand>()
                .With(x => x.Bathrooms, "3")
                .With(x => x.Bedrooms, "2")
                .With(x => x.SquareFeet, "200")
                .With(x => x.Floors, "2")
                .With(x => x.ZipCode, "22222")
                .With(x => x.YearBuilt, "2000")
                .With(x => x.Price, "2000000")
                .Create();

            var result = _validator.Validate(model);

            result.IsValid.Should().BeTrue();
        }

        [Test]
        public void WhenBedroomsIsMissing_ShouldReturnError()
        {
            var model = _fixture.Build<CreateHouseCommand>()
                .With(x => x.Bathrooms, "2")
                .Without(x => x.Bedrooms)
                .With(x => x.SquareFeet, "200")
                .With(x => x.Floors, "2")
                .With(x => x.ZipCode, "22222")
                .With(x => x.YearBuilt, "2000")
                .With(x => x.Price, "2000000")
                .Create();

           var result=  _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(x => x.Bedrooms);
        }
        [Test]
        public void WhenBathroomsIsMissing_ShouldReturnError()
        {
            var model = _fixture.Build<CreateHouseCommand>()
                .With(x => x.Bedrooms, "2")
                .Without(x => x.Bathrooms)
                .With(x => x.SquareFeet, "200")
                .With(x => x.Floors, "2")
                .With(x => x.ZipCode, "22222")
                .With(x => x.YearBuilt, "2000")
                .With(x => x.Price, "2000000")
                .Create();

            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(x => x.Bathrooms);
        }

        [Test]
        public void WhenSquarefeetIsMissing_ShouldReturnError()
        {
            var model = _fixture.Build<CreateHouseCommand>()
                .With(x => x.Bedrooms, "2")
                .With(x => x.Bathrooms, "2")
                .Without(x => x.SquareFeet)
                .With(x => x.Floors, "2")
                .With(x => x.ZipCode, "22222")
                .With(x => x.YearBuilt, "2000")
                .With(x => x.Price, "2000000")
                .Create();

            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(x => x.SquareFeet);
        }

        [Test]
        public void WhenFloorsIsMissing_ShouldReturnError()
        {
            var model = _fixture.Build<CreateHouseCommand>()
                .With(x => x.Bedrooms, "2")
                .With(x => x.Bathrooms, "2")
                .With(x => x.SquareFeet, "250")
                .Without(x => x.Floors)
                .With(x => x.ZipCode, "22222")
                .With(x => x.YearBuilt, "2000")
                .With(x => x.Price, "2000000")
                .Create();

            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(x => x.Floors);
        }

        [Test]
        public void WhenZipCodeIsMissing_ShouldReturnError()
        {
            var model = _fixture.Build<CreateHouseCommand>()
                .With(x => x.Bedrooms, "2")
                .With(x => x.Bathrooms, "2")
                .With(x => x.SquareFeet, "250")
                .With(x => x.Floors, "3")
                .Without(x => x.ZipCode)
                .With(x => x.YearBuilt, "2000")
                .With(x => x.Price, "2000000")
                .Create();

            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(x => x.ZipCode);
        }

        [Test]
        public void WhenYearBuiltIsMissing_ShouldReturnError()
        {
            var model = _fixture.Build<CreateHouseCommand>()
                .With(x => x.Bedrooms, "2")
                .With(x => x.Bathrooms, "2")
                .With(x => x.SquareFeet, "250")
                .With(x => x.Floors, "3")
                .With(x => x.ZipCode, "12345")
                .Without(x => x.YearBuilt)
                .With(x => x.Price, "2000000")
                .Create();

            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(x => x.YearBuilt);
        }
        [Test]
        public void WhenPriceIsMissing_ShouldReturnError()
        {
            var model = _fixture.Build<CreateHouseCommand>()
                .With(x => x.Bedrooms, "2")
                .With(x => x.Bathrooms, "2")
                .With(x => x.SquareFeet, "250")
                .With(x => x.Floors, "3")
                .With(x => x.ZipCode, "12345")
                .With(x => x.YearBuilt, "2011")
                .Without(x => x.Price)
                .Create();

            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(x => x.Price);
        }

    }
}
