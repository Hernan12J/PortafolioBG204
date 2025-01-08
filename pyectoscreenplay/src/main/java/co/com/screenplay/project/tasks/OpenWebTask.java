/**
 * @author Hernan J
 * @created 12/19/2024 7:45 a. m.
 */
package co.com.screenplay.project.tasks;

import net.serenitybdd.screenplay.Actor;
import net.serenitybdd.screenplay.Task;
import net.serenitybdd.screenplay.actions.Open;
import net.serenitybdd.screenplay.targets.Target;

public class OpenWebTask implements Task {

    private final String url;

    public OpenWebTask(String url) {
        this.url = url;
    }

    public static OpenWebTask onPage(String url) {
        return new OpenWebTask(url);
    }

    @Override
    public <T extends Actor> void performAs(T actor) {
        actor.attemptsTo(Open.url(url));
    }
}