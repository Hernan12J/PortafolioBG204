/**
 * @author Hernan J
 * @created 12/18/2024 4:20 p. m.
 */
package co.com.screenplay.project.question;


import lombok.AllArgsConstructor;
import lombok.extern.slf4j.Slf4j;
import net.serenitybdd.screenplay.Actor;
import net.serenitybdd.screenplay.Question;


import static co.com.screenplay.project.ui.HomeUi.TXT_RANDOM_NAME_BTN;

@AllArgsConstructor
@Slf4j

public class ValidateTextBtn implements Question<Boolean> {

    private String validTextSubElementBtn;

    @Override
    public Boolean answeredBy(Actor actor) {
        boolean result;
        String validTextBtnHeader = TXT_RANDOM_NAME_BTN.resolveFor(actor).getText();
        if (validTextBtnHeader != null && validTextSubElementBtn.equals(validTextBtnHeader)) {
            log.info(validTextBtnHeader);
            result = true;
        } else {
            result = false;
        }
        return result;
    }

    public static ValidateTextBtn witchParams(String validTextSubElementBtn) {
        return new ValidateTextBtn(validTextSubElementBtn);
    }
}
