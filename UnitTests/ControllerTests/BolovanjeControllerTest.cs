using AutoMapper;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MitrosremERP.Aplication.IRepositories;
using MitrosremERP.Aplication.ViewModels;
using MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM;
using MitrosremERP.Controllers;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.ControllerTests
{
    public class BolovanjeControllerTest
    {
        //[Fact]
        //public async Task Index_ReturnsViewWithPaginatedList()
        //{
        //    // Arrange
        //    var unitOfWork = A.Fake<IUnitOfWork>();
        //    var mapper = A.Fake<IMapper>();
        //    var logger = A.Fake<ILogger<BolovanjeController>>();

        //    // Set up your fake repository to return test data.
        //    Guid bolovanjeId = new Guid();
        //    var testBolovanjeData = new List<Bolovanje> { new Bolovanje { Id = bolovanjeId, BrojDanaBolovanja = 3 } };
        //    A.CallTo(() => unitOfWork.BolovanjeRepository.GetBolovanjePaginationAsync(A<string>._, A<string>._, A<int>._, A<int>._))
        //        .Returns(Task.FromResult(new PaginatedList<Bolovanje>(testBolovanjeData, testBolovanjeData.Count, 1, 3)));

        //    var controller = new BolovanjeController(unitOfWork, mapper, logger);

        //    // Act
        //    var result = await controller.Index(sortOrder: null, currentFilter: null, searchString: null, pageNumber: null) as ViewResult;

        //    // Assert
        //    result.Should().NotBeNull();
        //    var model = result.ViewData.Model as PaginatedList<BolovanjeVMIndex>;
        //    model.Should().NotBeNull();
        //    model.Should().BeEquivalentTo(testBolovanjeData); // Assuming AutoMapper is correctly configured
        //}

        //[Fact]
        //public async Task Create_WithValidId_ReturnsViewWithModel()
        //{
        //    // Arrange
        //    var unitOfWork = A.Fake<IUnitOfWork>();
        //    var mapper = A.Fake<IMapper>();
        //    var logger = A.Fake<ILogger<BolovanjeController>>();

        //    var testZaposleni = new Zaposleni { Id = Guid.NewGuid(), Ime = "Aleksandar Hadzic" };
        //    A.CallTo(() => unitOfWork.ZaposleniRepository.GetByIdAsync(A<Guid>._)).Returns(testZaposleni);


        //    var testBolovanjeData = new List<Bolovanje> { new Bolovanje { Id = Guid.NewGuid(), BrojDanaBolovanja = 3 } };
        //    A.CallTo(() => unitOfWork.BolovanjeRepository.GetQueryable(A<Func<Bolovanje, bool>>._)).Returns(testBolovanjeData);

        //    var controller = new BolovanjeController(unitOfWork, mapper, logger);

        //    // Act
        //    var result = await controller.Create(Guid.NewGuid()) as ViewResult;

        //    // Assert
        //    result.Should().NotBeNull();
        //    var model = result.ViewData.Model as KreirajBolovanjeVM;
        //    model.Should().NotBeNull();
        //    model.ZaposleniVM.Should().BeEquivalentTo(testZaposleni); // Assuming AutoMapper is correctly configured
        //    model.BolovanjeVMlista.Should().BeEquivalentTo(testBolovanjeData); // Assuming AutoMapper is correctly configured
        //}

        //[Fact]
        //public async Task Create_WithInvalidId_ReturnsNotFound()
        //{
        //    // Arrange
        //    var unitOfWork = A.Fake<IUnitOfWork>();
        //    var mapper = A.Fake<IMapper>();
        //    var logger = A.Fake<ILogger<BolovanjeController>>();

        //    A.CallTo(() => unitOfWork.ZaposleniRepository.GetByIdAsync(A<Guid>._)).Returns(null);

        //    var controller = new BolovanjeController(unitOfWork, mapper, logger);

        //    // Act
        //    var result = await controller.Create(Guid.NewGuid()) as NotFoundResult;

        //    // Assert
        //    result.Should().NotBeNull();
        //}






        ///////////////////////////////////
        //[Fact]
        //  public async Task Index_ReturnsViewWithModel()
        //  {
        //      // Arrange
        //      var unitOfWork = A.Fake<IUnitOfWork>();
        //      var mapper = A.Fake<IMapper>();
        //      var logger = A.Fake<ILogger<BolovanjeController>>();

        //      Guid bolovanjeId = new Guid(); 
        //      // Set up your fake repository or service to return test data.
        //      var testBolovanjeData = new List<Bolovanje> { new Bolovanje { Id = bolovanjeId, BrojDanaBolovanja = 3 } };
        //      A.CallTo(() => unitOfWork.BolovanjeRepository.GetBolovanjePaginationAsync(A<string>._, A<string>._, A<int>._, A<int>._)).ReturnsAsync(new PaginatedList<Bolovanje>(testBolovanjeData, testBolovanjeData.Count, pageNumber ?? 1, pageSize));
        //      // Create the controller
        //      var controller = new BolovanjeController(unitOfWork, mapper, logger);

        //      // Act
        //      var result = await controller.Index(sortOrder: null, currentFilter: null, searchString: null, pageNumber: null) as ViewResult;

        //      // Assert
        //      result.Should().NotBeNull();
        //      result.Model.Should().BeAssignableTo<IEnumerable<BolovanjeVMIndex>>();
        //  }

        //  [Fact]
        //  public async Task Create_WithValidId_ReturnsViewWithModel()
        //  {
        //      // Arrange
        //      var unitOfWork = A.Fake<IUnitOfWork>();
        //      var mapper = A.Fake<IMapper>();
        //      var logger = A.Fake<ILogger<BolovanjeController>>();

        //      Guid zaposleniId = new Guid();
        //      var testZaposleni = new Zaposleni { Id = zaposleniId, Ime = "Aleksandar Hadzic" };
        //      A.CallTo(() => unitOfWork.ZaposleniRepository.GetByIdAsync(A<Guid>._)).Returns(testZaposleni);

        //      // Create the controller
        //      var controller = new BolovanjeController(unitOfWork, mapper, logger);

        //      // Act
        //      var result = await controller.Create(Guid.NewGuid()) as ViewResult;

        //      // Assert
        //      result.Should().NotBeNull();
        //      result.ViewData.Model.Should().BeAssignableTo<KreirajBolovanjeVM>();
        //  }

        //  [Fact]
        //  public async Task Create_WithInvalidId_ReturnsNotFound()
        //  {
        //      // Arrange
        //      var unitOfWork = A.Fake<IUnitOfWork>();
        //      var mapper = A.Fake<IMapper>();
        //      var logger = A.Fake<ILogger<BolovanjeController>>();

        //      A.CallTo(() => unitOfWork.ZaposleniRepository.GetByIdAsync(A<Guid>._)).Returns(null); // Simulate a case where Zaposleni is not found.

        //      // Create the controller
        //      var controller = new BolovanjeController(unitOfWork, mapper, logger);

        //      // Act
        //      var result = await controller.Create(Guid.NewGuid()) as NotFoundResult;

        //      // Assert
        //      result.Should().NotBeNull();
        //  }
    }
}
