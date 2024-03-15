using Gotracrat.POM;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace StoreAdmin_BDD.StepDefinitions
{
    [Binding]
    public class GotracratAutomationTestingStepDefinitions  : GotracratPageObjectModel
    {   //User Navigates to URL
        [Given(@"the User navigates to the Gotracrat website")]
        public void GivenTheUserNavigatesToTheGotracratWebsite()
        {
           






        }
        //Login With Credentials
        [When(@"the User logs in with valid credentials")]
        public void WhenTheUserLogsInWithValidCredentials()
        {


            UserLoginWithCredentials();



        }


        //Useer Selects The dropDown for select company
        [When(@"the User selects '([^']*)'")]
        public void WhenTheUserSelects(string DropdownName)
        {
          

            UserSelects(DropdownName);



        }
        //For Random Click
        [When(@"the User performs a random selection in the Company List")]
        public void WhenTheUserPerformsARandomSelectionInTheCompanyList()
        {


            randomClick();



        }
        //For Selected Click
        [When(@"the User Selected the '([^']*)' in the Company List")]
        public void WhenTheUserSelectedTheInTheCompanyList(string company)
        {


            TheUserSelectedTheCompanyInTheCompanyList(company);


        }
        //User Click on manage company
        [When(@"the User click on '([^']*)'")]
        public void WhenTheUserClickOn(string manageCompany)
        {


            ManageCompany(manageCompany);



        }

        [When(@"the User clicks on '([^']*)'")]
        public void WhenTheUserClicksOn(string AddCompany)
        {


            addCompany(AddCompany);


        }

        [When(@"the User enters the Company Name as '([^']*)'")]
        public void WhenTheUserEntersTheCompanyNameAs(string name)
        {
            //CyberTowers2
            enterText(name);

        }

        [When(@"the User clicks on the save button")]
        public void WhenTheUserClicksOnTheSaveButton()
        {


            saveButton();



        }

        [When(@"the User selects a randomly added Company")]
        public void WhenTheUserSelectsARandomlyAddedCompany()
        {
            ClickOnDropdown();
            TheUserSelectsARandomlyAddedCompany();

        }






        [When(@"the User selected the recently selected Company")]
        public void WhenTheUserSelectedTheRecentlySelectedCompany()
        {


            userSelectedTheRecentlySelectedCompany();
        }





        [When(@"the User clicked on '([^']*)'")]
        public void WhenTheUserClickedOn(string manageCompany)
        {

            ManageCompany(manageCompany);

        }

        [When(@"the User enters the search Text")]
        public void WhenTheUserEntersTheSearchText()
        {


            enterTextOnSeatchBar();





        }

        [Then(@"the User validates the Text in the search bar matches the entered text")]
        public void ThenTheUserValidatesTheTextInTheSearchBarMatchesTheEnteredText()
        {


            ValidationForCompanyName();

        }
    }
}
