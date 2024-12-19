/**
 * @author Hernan J
 * @created 12/17/2024 11:46 p. m.
 */
package co.com.screenplay.project.hook;

import lombok.AllArgsConstructor;
import net.serenitybdd.core.environment.EnvironmentSpecificConfiguration;
import net.serenitybdd.screenplay.Actor;
import net.serenitybdd.screenplay.Performable;
import net.serenitybdd.screenplay.Task;
import net.serenitybdd.screenplay.actions.Open;
import net.thucydides.core.annotations.Step;
import net.thucydides.core.util.EnvironmentVariables;

import static co.com.screenplay.project.utils.Cons.WEB_URL;
import static net.serenitybdd.screenplay.Tasks.instrumented;

@AllArgsConstructor
public class OpenWeb implements Task {

    private EnvironmentVariables environmentVariables;
    private String webUrl;

    @Override
    @Step("{0}Abrir navegador edge")
    public <T extends Actor> void performAs(T actor) {
        String pathWebURL = EnvironmentSpecificConfiguration.from(environmentVariables).getProperty(webUrl);
        actor.attemptsTo(Open.url(pathWebURL));
    }

    public static Performable browserURL(String webUrl) {
        return instrumented(OpenWeb.class,webUrl);
    }
}
