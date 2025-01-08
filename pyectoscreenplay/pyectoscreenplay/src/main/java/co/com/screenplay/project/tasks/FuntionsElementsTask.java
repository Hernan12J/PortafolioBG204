/**
 * @author Hernan J
 * @created 12/18/2024 1:28 p. m.
 */
package co.com.screenplay.project.tasks;

import net.serenitybdd.screenplay.Actor;
import net.serenitybdd.screenplay.Task;
import net.serenitybdd.screenplay.Tasks;
import net.serenitybdd.screenplay.actions.Click;
import net.serenitybdd.screenplay.actions.Scroll;
import net.serenitybdd.screenplay.waits.WaitUntil;
import net.thucydides.core.annotations.Step;

import static co.com.screenplay.project.ui.HomeUi.ID_CARD_ELEMENTS;
import static co.com.screenplay.project.utils.Cons.TIME_SHORT;
import static net.serenitybdd.screenplay.matchers.WebElementStateMatchers.isEnabled;

public class FuntionsElementsTask implements Task {
    @Override
    @Step("{0}Se selecciona el ID card Elements")
    public <T extends Actor> void performAs(T actor) {
        actor.attemptsTo(Scroll.to(ID_CARD_ELEMENTS));
        actor.attemptsTo(WaitUntil.the(ID_CARD_ELEMENTS, isEnabled())
                        .forNoMoreThan(TIME_SHORT).seconds(),
                Click.on(ID_CARD_ELEMENTS));
    }
    public static FuntionsElementsTask choose(){
        return  Tasks.instrumented(FuntionsElementsTask.class);
    }
}
