package examples.pet;

import com.intuit.karate.junit5.Karate;

public class petRunner {
    @Karate.Test
    Karate searchPet() {
        return Karate.run("search_pet").relativeTo(getClass());
    }
}
