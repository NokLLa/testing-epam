using TESTPOLAST.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTPOLAST.Steps;
using TESTPOLAST.Utils;
using SeleniumExtras.PageObjects;

namespace TESTPOLAST.AllTestsLibcat
{
    public class Tests
    {
        private Steps.Steps steps = new Steps.Steps();

        private const string BookName = "Пенелопа Уорд";
        private const string keyToReview = "Советую книгу";
        private const string complaintText = "Жалоба";


        [SetUp]
        public void Init()
        {
            steps.Init();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.Cleanup();
        }

        //1 10lab
        [Test]
        public void SearchBook()
        {
            steps.SearchBookMainPage(BookName);
        }

        //2 10lab
        [Test]
        public void ReviewBookSend()
        {
            steps.Login();
            steps.OpenImperialVoyageBook();
            steps.SendReviewKeys(keyToReview);

        }

        //3 
        [Test]
        public void addFavoriteBook()
        {
            steps.Login();
            steps.addFavoriteBookButtonVoyageBook();
        }


        //4
        [Test]
        public void deleteFavoriteBook()
        {
            steps.Login();
            steps.deleteFavoriteBookButtonVoyageBook();
        }

        //5
        [Test]
        public void bookMark()
        {
            steps.OpenImperialVoyageBook();
            steps.bookMarkClick();
        }

        //6
        [Test]
        public void intervalChange()
        {
            steps.OpenImperialVoyageBook();
            steps.intervalChange();
        }

        //7
        [Test]
        public void autorBooksOpen()
        {
            steps.OpenImperialVoyageBook();
            steps.openAutorBooks();
        }

        //8
        [Test]
        public void fantasticBooksOpen()
        {
            steps.OpenImperialVoyageBook();
            steps.fantasticBooksOpen();
        }


        //9
        [Test]
        public void similarBooksOpen()
        {
            steps.OpenImperialVoyageBook();
            steps.similarBooksOpen();

        }

        //10
        [Test]
        public void badReviewSend()
        {
            steps.Login();
            steps.OpenImperialVoyageBook();
            steps.badReviewBook();
        }


    }
}
