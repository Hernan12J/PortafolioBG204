/**
 * @author Hernan J
 * @created 12/18/2024 1:20 p. m.
 */
package co.com.screenplay.project.ui;

import net.serenitybdd.core.pages.PageObject;
import net.serenitybdd.screenplay.targets.Target;
import org.openqa.selenium.By;

public class HomeUi extends PageObject {
    public static final Target ID_CARD_ELEMENTS= Target.the("Boton elementos")
            .located(By.xpath ("//div[@class='card mt-4 top-card']//div[@class='card-body']//h5[contains(text(),'Elements')]"));

    public static final Target BTN_ELEMENTS= Target.the("Boton elementos")
            .located(By.xpath("//div[@class='header-wrapper']//div[contains(text(),'Elements')]"));


    public static final Target BTN_LIST_ELEMENTS = Target.the("boton lista opciones elementos")
            .locatedBy("//ul[@class='menu-list']/li[{0}]");

    public static final Target TXT_RANDOM_NAME_BTN= Target.the("texto random, del nombre de los botones")
            .located(By.xpath("//h1[@class='text-center']"));
}
