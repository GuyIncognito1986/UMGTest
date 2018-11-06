using NUnit.Framework;
using SeleniumCoreFramework.PageObjectModel;
using SeleniumCoreFramework.DataBuilders.TestPocos;
using TechTalk.SpecFlow;


namespace SpecflowTests.StepFiles
{
    [Binding]
    public sealed class AccountCreationSteps
    {
        [Given(@"I am not logged in")]
        public void GivenIAmNotLoggedIn()
        {
            var page = (SignUpPage)ContextBuilders.Context.Current.PageFactory.Build<SignUpPage>();
            page.NavigateToPage();
            page.Validate();
        }

        [When(@"I complete the sign up form")]
        public void WhenICompleteTheSignUpForm()
        {
            var page = (SignUpPage)ContextBuilders.Context.Current.PageFactory.Build<SignUpPage>();
            var userData = UserDetailsPoco.Random(20);
            ScenarioContext.Current.Add(typeof(UserDetailsPoco).Name, userData);
            page.FillInForm(userData);
            page.SubmitForm();
        }

        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            var page = (PostLoginHomePage)ContextBuilders.Context.Current.PageFactory.Build<PostLoginHomePage>();
            page.Validate();
        }

        [Then(@"my username is displayed")]
        public void ThenMyUsernameIsDisplayed()
        {
            var page = (PostLoginHomePage)ContextBuilders.Context.Current.PageFactory.Build<PostLoginHomePage>();
            var userData = ScenarioContext.Current.Get<UserDetailsPoco>(typeof(UserDetailsPoco).Name);
            Assert.IsTrue(page.UserNameIsPresent(userData.Username));
        }

    }
}
