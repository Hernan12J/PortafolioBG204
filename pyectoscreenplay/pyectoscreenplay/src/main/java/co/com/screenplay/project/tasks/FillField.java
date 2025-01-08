/**
 * @author Hernan J
 * @created 12/19/2024 10:06 a. m.
 */
package co.com.screenplay.project.tasks;

import net.serenitybdd.screenplay.Actor;
import net.serenitybdd.screenplay.Performable;
import net.serenitybdd.screenplay.Task;
import net.serenitybdd.screenplay.Tasks;
import net.serenitybdd.screenplay.actions.Enter;

import static co.com.screenplay.project.ui.HomeUi.FORM_LASTNAME_FIELD;
import static co.com.screenplay.project.ui.HomeUi.FORM_NAME_FIELD;
import static net.serenitybdd.screenplay.Tasks.instrumented;

public class FillField implements Task {
    private final String name = "Hernan";
    private final String lastName = "Hernandez";



    public static Performable with(String name) {
        return instrumented(FillField.class, name);
    }
    @Override
    public <T extends Actor> void performAs(T actor) {
        actor.attemptsTo(
                Enter.theValue(name).into(FORM_NAME_FIELD),
                Enter.theValue(lastName).into(FORM_LASTNAME_FIELD)
        );
    }
    public static FillField fillF() {
        return Tasks.instrumented(FillField.class);

    }
}
