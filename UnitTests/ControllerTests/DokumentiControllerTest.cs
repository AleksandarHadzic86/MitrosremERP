using AutoMapper;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MitrosremERP.Application.IRepositories;
using MitrosremERP.Application.ViewModels.ZaposleniMitroSremVM;
using MitrosremERP.Web.Controllers;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;


namespace UnitTests.ControllerTests
{
    public class DokumentiControllerTest
    {
        [Fact]
        public async void Create_WithValidId_ReturnsView()
        {
            // Arrange
            var unitOfWork = A.Fake<IUnitOfWork>();
            var mapper = A.Fake<IMapper>();
            var logger = A.Fake<ILogger<DokumentiController>>();
            var webHostEnv = A.Fake<IWebHostEnvironment>();
            Guid dokumentId = new Guid();
            var dokument = A.Fake<DokumentiZaposleni>();
            var dokumentLista = A.Fake<List<DokumentiZaposleniVM>>();
            var zaposleni = A.Fake<Zaposleni>();
            var expectedKreirajBolovanjeVM = new KreirajDokumenteZaposleniVM();
            var expectedDokumentVM = new DokumentiZaposleniVM();
            var expectedZaposleniVM = new ZaposleniVM();
            var controller = new DokumentiController(unitOfWork, mapper, logger, webHostEnv);

            A.CallTo(() => unitOfWork.DokumentiRepository.GetByIdAsync(dokumentId)).Returns(dokument);

            A.CallTo(() => mapper.Map<IEnumerable<DokumentiZaposleniVM>>(A<IEnumerable<DokumentiZaposleni>>._)).Returns(dokumentLista);
            A.CallTo(() => mapper.Map<DokumentiZaposleniVM>(A<DokumentiZaposleni>._)).Returns(expectedDokumentVM);
            A.CallTo(() => mapper.Map<ZaposleniVM>(A<Zaposleni>._)).Returns(expectedZaposleniVM);

            // Act
            var result = await controller.Create(dokumentId) as ViewResult;

            // Assert
            result.Model.Should().BeOfType<KreirajDokumenteZaposleniVM>();
            result.Model.As<KreirajDokumenteZaposleniVM>().DokumentiZaposleniVM.Should().BeEquivalentTo(expectedDokumentVM);
            result.Model.As<KreirajDokumenteZaposleniVM>().ZaposleniVM.Should().BeEquivalentTo(expectedZaposleniVM);
            result.Model.As<KreirajDokumenteZaposleniVM>().DokumentiZaposleniVMlista.Should().BeEquivalentTo(dokumentLista);

            result.Should().BeOfType<ViewResult>();
            result.ViewName.Should().Be("Create");

        }
        //[Fact]
        //public async Task Create_WithValidModel_ReturnsRedirectToAction()
        //{
        //    // Arrange
        //    var unitOfWork = A.Fake<IUnitOfWork>();
        //    var mapper = A.Fake<IMapper>();
        //    var logger = A.Fake<ILogger<DokumentiController>>();
        //    var webHostEnv = A.Fake<IWebHostEnvironment>();
        //    var kreirajDokumenteZaposleniVM = A.Fake<KreirajDokumenteZaposleniVM>();

        //    var fakeFileStream = A.Fake<Stream>();

        //    var controller = new DokumentiController(unitOfWork, mapper, logger, webHostEnv);

        //    // Mock the HttpContext to simulate a file upload
        //    var httpContext = new DefaultHttpContext();
        //    httpContext.Request.Form = new FormCollection(new Dictionary<string, StringValues>());
        //    httpContext.Request.Form.Files.Add(new FormFile(fakeFileStream, 0, fakeFileStream.Length, "file", "file.pdf"));

        //    controller.ControllerContext = new ControllerContext { HttpContext = httpContext };

        //    A.CallTo(() => unitOfWork.DokumentiRepository.Insert(A<DokumentiZaposleni>._))
        //        .Invokes((DokumentiZaposleni dokument) =>
        //        {
        //            // You can put your assertions or logic here
        //            // For example, you can check the properties of the inserted DokumentiZaposleni
        //        });

        //    A.CallTo(() => unitOfWork.SaveAsync()).Returns(Task.FromResult(true));

        //    // Act
        //    var result = await controller.Create(kreirajDokumenteZaposleniVM) as IActionResult;

        //    // Assert
        //    result.Should().BeOfType<RedirectToActionResult>();
        //    var redirectToActionResult = result as RedirectToActionResult;
        //    redirectToActionResult.ActionName.Should().Be("Create"); // Change to your expected action name

        //    // Additional assertions as needed
        //}




    }
}
