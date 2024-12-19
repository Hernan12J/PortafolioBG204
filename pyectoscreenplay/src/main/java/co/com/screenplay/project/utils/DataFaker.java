/**
 * @author Hernan J
 * @created 12/18/2024 4:00 p. m.
 */
package co.com.screenplay.project.utils;

import com.github.javafaker.Faker;

import java.util.Locale;

public class DataFaker {

    private DataFaker(){}

    public static Faker faker = Faker.instance(new Locale("es","PA"));

    public static String fakerNumberOneAndNine(){
        return String.valueOf(faker.number().numberBetween(1,9));
    }
}
