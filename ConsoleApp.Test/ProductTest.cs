﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace ConsoleApp.Test
{
    [TestClass]
    public class ProductTest
    {
        private const int DummyInt = 1;
        private const string DummyName = "DummyName";
        private const string DummyDescription = "Some description for product"; 
        private Product _sut;

        [TestInitialize]
        public void SetUp()
        {
            _sut = new Product(DummyInt, DummyName, DummyDescription);
        }

        [TestMethod]
        public void Name_WhenProductInitialized_ReturnsName()
        {
            // Arrange
            var expectedName = DummyName;

            // Act
            var name = _sut.Name;

            // Assert
            name.ShouldBe(expectedName);
        }

        [TestMethod]
        public void Id_WhenProductInitialized_ReturnsId()
        {
            // Arrange
            var expectedId = DummyInt;

            // Act
            var id = _sut.Id;

            // Assert
            id.ShouldBe(expectedId);
        }

        [TestMethod]
        public void Description_WhenProductInitialized_ReturnsDescription()
        {
            // Arrange
            var expectedDescription = DummyDescription;

            // Act
            var desc = _sut.Description;

            // Assert
            desc.ShouldBe(expectedDescription);
        }
    }
}
