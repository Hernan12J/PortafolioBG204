/**
 * @author Hernan J
 * @created 12/17/2024 11:05 p. m.
 */
package co.com.screenplay.project.stepdefinition;

import co.com.screenplay.project.question.ValidateTextBtn;
import co.com.screenplay.project.tasks.ChooseRandomTask;
import co.com.screenplay.project.tasks.FuntionsElementsTask;
import io.cucumber.java.en.And;
import io.cucumber.java.en.Then;
import io.cucumber.java.en.When;
import lombok.extern.slf4j.Slf4j;
import net.serenitybdd.screenplay.actors.OnStage;
import net.serenitybdd.screenplay.actors.OnlineCast;
import org.junit.Before;

import static co.com.screenplay.project.utils.Cons.ACTOR;
import static co.com.screenplay.project.utils.Cons.REMEMBER_TEXT_BTN_SUB_ELEMENTS;
import static co.com.screenplay.project.utils.DataFaker.fakerNumberOneAndNine;
import static net.serenitybdd.screenplay.GivenWhenThen.seeThat;
import static net.serenitybdd.screenplay.actors.OnStage.theActorInTheSpotlight;

@Slf4j
public class OpenWebStep {
    @Before
    public void setTheStage() {
        OnStage.setTheStage(new OnlineCast());
    }


    @And("validar funcion del menu de elementos")
    public void validateMenuElementsFunction() {
        OnStage.theActorCalled(ACTOR).attemptsTo(FuntionsElementsTask.choose());
    }

    @When("selecciona aleatoriamente alguna de las subfunciones")
    public void selectRandomlyOneOfTheSubfunctions() {
        OnStage.theActorCalled(ACTOR).attemptsTo(ChooseRandomTask.witchParams(fakerNumberOneAndNine()));
    }

    @Then("visualizara en la cabecera el nombre de la opcion elegida")
    public void willDisplayTheNameOfTheSelectedOptionInTheHeader() {
        String validateText = OnStage.theActor(ACTOR).recall(REMEMBER_TEXT_BTN_SUB_ELEMENTS);
        if (validateText != null) {
            log.info(validateText);
        }
        theActorInTheSpotlight().should(seeThat(ValidateTextBtn.witchParams(validateText)));
    }
}
