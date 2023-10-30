using AutoMapper;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MitrosremERP.Application.IRepositories;
using MitrosremERP.Application.ViewModels.ZaposleniMitroSremVM;
using MitrosremERP.Web.Controllers;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;


namespace UnitTests.ControllerTests
{
    public class BolovanjeControllerTest
    {
        [Fact]
        public async void Index_ReturnsView()
        {
            // Arrange
            var unitOfWork = A.Fake<IUnitOfWork>();
            var mapper = A.Fake<IMapper>();
            var logger = A.Fake<ILogger<BolovanjeController>>();

            var controller = new BolovanjeController(unitOfWork, mapper, logger);

            // Act
            var result = await controller.Index(sortOrder: null, currentFilter: null, searchString: null, pageNumber: null);

            // Assert
            result.Should().BeOfType<ViewResult>();
        }

        [Fact]
        public async void Create_WithValidId_ReturnsView()
        {
            // Arrange
            var unitOfWork = A.Fake<IUnitOfWork>();
            var mapper = A.Fake<IMapper>();
            var logger = A.Fake<ILogger<BolovanjeController>>();
            Guid bolovanjeId = new Guid();
            var bolovanje = A.Fake<Bolovanje>();
            var bolovanjeLista = A.Fake<List<BolovanjeVM>>();
            var zaposleni = A.Fake<Zaposleni>();
            var expectedKreirajBolovanjeVM = new KreirajBolovanjeVM();
            var expectedBolovanjeVM = new BolovanjeVM();
            var expectedZaposleniVM = new ZaposleniVM();
            var controller = new BolovanjeController(unitOfWork, mapper, logger);

            A.CallTo(() => unitOfWork.BolovanjeRepository.GetByIdAsync(bolovanjeId)).Returns(bolovanje);

            A.CallTo(() => mapper.Map<IEnumerable<BolovanjeVM>>(A<IEnumerable<Bolovanje>>._)).Returns(bolovanjeLista);
            A.CallTo(() => mapper.Map<BolovanjeVM>(A<Bolovanje>._)).Returns(expectedBolovanjeVM);
            A.CallTo(() => mapper.Map<ZaposleniVM>(A<Zaposleni>._)).Returns(expectedZaposleniVM);

            // Act
            var result = await controller.Create(bolovanjeId) as ViewResult;

            // Assert
            result.Model.Should().BeOfType<KreirajBolovanjeVM>();
            result.Model.As<KreirajBolovanjeVM>().BolovanjeVM.Should().BeEquivalentTo(expectedBolovanjeVM);
            result.Model.As<KreirajBolovanjeVM>().ZaposleniVM.Should().BeEquivalentTo(expectedZaposleniVM);
            result.Model.As<KreirajBolovanjeVM>().BolovanjeVMlista.Should().BeEquivalentTo(bolovanjeLista);

            result.Should().BeOfType<ViewResult>();
            result.ViewName.Should().Be("Create");

            
        }



    }
}
