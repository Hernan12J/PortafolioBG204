/**
 * @author Hernan J
 * @created 12/19/2024 6:34 a. m.
 */
package co.com.screenplay.project.ui;

import net.serenitybdd.screenplay.targets.Target;
import org.openqa.selenium.By;

public class FormUi {
    public static final Target FIRST_NAME = Target.the("Campo de texto para el nombre")
            .located(By.id("firstName"));

    public static final Target LAST_NAME = Target.the("Campo de texto para el apellido")
            .located(By.id("lastName"));

    public static final Target EMAIL = Target.the("Campo de texto para el correo")
            .located(By.id("userEmail"));

    public static final Target GENDER = Target.the("Botón de selección para el género")
            .locatedBy("//label[contains(text(), '{0}')]");

    public static final Target MOBILE_NUMBER = Target.the("Campo de texto para el número móvil")
            .located(By.id("userNumber"));
}

