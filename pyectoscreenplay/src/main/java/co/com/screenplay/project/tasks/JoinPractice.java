/**
 * @author Hernan J
 * @created 12/19/2024 9:34 a. m.
 */
package co.com.screenplay.project.tasks;

import lombok.AllArgsConstructor;
import net.serenitybdd.screenplay.Actor;
import net.serenitybdd.screenplay.Task;
import net.serenitybdd.screenplay.Tasks;
import net.serenitybdd.screenplay.actions.Click;
import net.serenitybdd.screenplay.actions.Scroll;
import net.serenitybdd.screenplay.waits.WaitUntil;
import org.openqa.selenium.interactions.Pause;

import static co.com.screenplay.project.ui.HomeUi.*;
import static co.com.screenplay.project.utils.Cons.TIME_SHORT;
import static net.serenitybdd.screenplay.matchers.WebElementStateMatchers.isEnabled;

@AllArgsConstructor
public class JoinPractice implements Task {
    @Override
    public <T extends Actor> void performAs(T actor) {
        actor.attemptsTo(
                WaitUntil.the(ID_CARD_FORMS, isEnabled()).forNoMoreThan(TIME_SHORT).seconds(),
                Click.on(ID_CARD_FORMS),
                Click.on(BTN_PRACTICE),
                WaitUntil.the(TITLE_PRATICE_FORM, isEnabled()).forNoMoreThan(TIME_SHORT).seconds()
        );
    }
    public static JoinPractice click(){
        return  Tasks.instrumented(JoinPractice.class);
    }
}

