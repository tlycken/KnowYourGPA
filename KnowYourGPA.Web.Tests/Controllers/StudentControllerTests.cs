using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using FluentAssertions;
using KnowYourGPA.Web.Controllers;
using KnowYourGPA.Web.Models.View;
using NUnit.Framework;

namespace KnowYourGPA.Web.Tests.Controllers
{
	[TestFixture]
	public class StudentControllerTests
	{
		[Test]
		public void GetStudentsReturnsViewWithListOfStudents()
		{
			var sut = new StudentsController();

			var result = sut.List();

			result.Should().BeOfType<ViewResult>();
			result.As<ViewResult>().Model.Should().BeAssignableTo<IEnumerable<StudentViewModel>>();
		}
	}
}
