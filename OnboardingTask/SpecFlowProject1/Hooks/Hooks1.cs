using OnboardingMars.Pages;
using TechTalk.SpecFlow;

namespace OnboardingMars.Hooks
{
    [Binding]
    public sealed class Hooks1 :Drivers.CommonDrivers
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        SignIn signInObj = new SignIn();
        
        [BeforeScenario]
        public void SetUp()
        {
            // launch the browser
            navigate();
            
        }
                
        [AfterScenario]
        public void tearDown()
        {
           signInObj.signOut();
           driver.Close();
        }
    }
}