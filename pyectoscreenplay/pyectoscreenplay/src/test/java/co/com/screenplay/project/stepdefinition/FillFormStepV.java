/**
 * @author Hernan J
 * @created 12/19/2024 9:10 a. m.
 */
package co.com.screenplay.project.stepdefinition;


import co.com.screenplay.project.tasks.FillField;
import co.com.screenplay.project.tasks.FuntionsElementsTask;
import co.com.screenplay.project.tasks.FuntionsFormsTask;
import co.com.screenplay.project.tasks.JoinPractice;
import groovy.util.logging.Slf4j;
import io.cucumber.java.en.And;
import io.cucumber.java.en.When;
import net.serenitybdd.screenplay.actors.OnStage;
import net.serenitybdd.screenplay.actors.OnlineCast;
import org.junit.Before;

import static co.com.screenplay.project.utils.Cons.ACTOR;

@Slf4j
public class FillFormStepV {

    @Before
    public void setTheStage() {
        OnStage.setTheStage(new OnlineCast());
    }
    @And("Validar menu de Forms")
    public void validateMenuFromsFunction() {
        OnStage.theActorCalled(ACTOR).attemptsTo(JoinPractice.click());
    }

    @When("Selecciona Practice From")
    public void selectPracticeForm(){
    }

    @And("Llena el formulario con los datos requeridos")
    public void fillForm(){
       OnStage.theActorCalled(ACTOR).attemptsTo(FillField.fillF());
    }
}
