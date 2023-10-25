using NetArchTest.Rules;
using System;

namespace ArchitectureTests
{
    public class ArchitectureTest
    {
        [Fact]
        public void ApplicationShouldNotReferenceInPresentation()
        {
            var result = Types.InCurrentDomain()
                .That()
                .ResideInNamespace("MitrosremERP.Aplication")
                .ShouldNot()
                .HaveDependencyOn("MitrosremERP.Web")
                .GetResult();

            Assert.True(result.IsSuccessful);
        }
        [Fact]
        public void ApplicationShouldNotReferenceInfrastructure()
        {
            var result = Types.InCurrentDomain()
                .That()
                .ResideInNamespace("MitrosremERP.Aplication")
                .ShouldNot()
                .HaveDependencyOn("MitrosremERP.Infrastructure")
                .GetResult();

            Assert.True(result.IsSuccessful);
        }
        [Fact]
        public void InfrastructureShouldNotReferenceInWeb()
        {
            var result = Types.InCurrentDomain()
                .That()
                .ResideInNamespace("MitrosremERP.Infrastructure")
                .ShouldNot()
                .HaveDependencyOn("MitrosremERP.Web")
                .GetResult();

            Assert.True(result.IsSuccessful);
        }
        [Fact]
        public void WebShouldNotReferenceInInfrastructure()
        {
            var result = Types.InCurrentDomain()
                .That()
                .ResideInNamespace("MitrosremERP.Web")
                .ShouldNot()
                .HaveDependencyOn("MitrosremERP.Infrastructure")
                .GetResult();

            Assert.True(result.IsSuccessful);
        }

    }
}