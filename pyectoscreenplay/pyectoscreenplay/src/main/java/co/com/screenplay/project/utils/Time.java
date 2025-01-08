/**
 * @author Hernan J
 * @created 12/18/2024 8:03 a. m.
 */
package co.com.screenplay.project.utils;

public class Time {
    private Time() {
    }

    public static void waitting(int waitting) {
        try {
            Thread.sleep(waitting * 1000L);
        } catch (InterruptedException e) {
            e.printStackTrace();
            Thread.currentThread().interrupt();
        }
    }

}
