/**
 * @author Hernan J
 * @created 12/19/2024 7:21 a. m.
 */
package co.com.screenplay.project.ui;
import net.serenitybdd.screenplay.targets.Target;

public class HomePage {
    public static final Target FORMS_BUTTON = Target.the("Botón de Forms")
            .locatedBy("//*[text()='Forms']");
}