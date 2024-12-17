package examples.GeoName;

import com.intuit.karate.junit5.Karate;

public class GeographicalDataGetRunner {
    @Karate.Test
    Karate geoNames() {
        return Karate.run().relativeTo(getClass());
    }
}
