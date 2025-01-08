/**
 * @author Hernan J
 * @created 12/19/2024 9:15 a. m.
 */
package co.com.screenplay.project.tasks;

import net.serenitybdd.screenplay.Actor;
import net.serenitybdd.screenplay.Task;
import net.serenitybdd.screenplay.Tasks;
import net.serenitybdd.screenplay.actions.Click;
import net.serenitybdd.screenplay.actions.Scroll;
import net.serenitybdd.screenplay.waits.WaitUntil;
import net.thucydides.core.annotations.Step;

import static co.com.screenplay.project.ui.HomeUi.ID_CARD_FORMS;
import static co.com.screenplay.project.utils.Cons.TIME_SHORT;
import static net.serenitybdd.screenplay.matchers.WebElementStateMatchers.isEnabled;

public class FuntionsFormsTask implements Task {
    @Override
    @Step("{0}Se selecciona el ID card Forms")
    public <T extends Actor> void performAs(T actor) {
        actor.attemptsTo(Scroll.to(ID_CARD_FORMS));
        actor.attemptsTo(WaitUntil.the(ID_CARD_FORMS, isEnabled())
                        .forNoMoreThan(TIME_SHORT).seconds(),
                Click.on(ID_CARD_FORMS));
    }
    public static FuntionsElementsTask choose(){
        return  Tasks.instrumented(FuntionsElementsTask.class);
    }
}
