using OpenQA.Selenium;

namespace ldb
{
    public static class PageObjects
    {
        //BUC
        public static By sukurtiAtveji = By.LinkText("Sukurti Nedarbo atvejį");
        public static By buc02 = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Sukurti Nedarbo atvejį'])[1]/following::dt[1]");
        public static By gavejoSalis = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Gavėjo šalis:'])[1]/following::select[1]");
        public static By gavejas = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='*Gavėjas'])[1]/following::select[1]");
        public static By surastiMygtukas = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='*Asmens kodas'])[1]/following::button[1]");
        public static By saugotiBUC = By.XPath("//button[@class='MainButton NotPrintable']");
        public static By personPIN = By.Name("personCode");

        //SED
        public static By selectorSED = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Auditas'])[1]/following::select[1]");
        public static By u009 = By.XPath("//*[@id='mat - tab - content - 0 - 0']/div/div/select[1]/option[2]");
        
        public static By bePIN = By.Name("unknownPIN");

        //SED U007
        public static By u007 = By.XPath("//*[@id='mat-tab-content-0-0']/div/div/select[1]/option[3]");
        public static By gimimoMiestas7 = By.XPath("//input[@class='ng-pristine ng-invalid ng-star-inserted ng-touched']");
        public static By gimimoSalis7 = By.XPath("//select[@class='ng-pristine ng-invalid ng-star-inserted ng-touched']");

        public static By eessiKlasifikatorius7 = By.XPath("//div[1]/label[@class=' ' and 1]/input[1]");
        public static By eessiKlasSalis = By.XPath("//select[@class='flex-field ng-untouched ng-pristine ng-valid']");
        public static By eessiKlasIst = By.XPath("//select[@class='flex-field ng-untouched ng-pristine ng-valid']");
        public static By saugotiSED = By.XPath("//button[@class='MainButton NotPrintable']");
        




    }

}
