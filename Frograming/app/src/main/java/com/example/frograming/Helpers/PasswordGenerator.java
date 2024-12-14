package com.example.frograming.Helpers;

public class PasswordGenerator {

    private static char mayuscula() {
        return (char) Math.floor(Math.random() * (90 - 65 + 1) + 65);
    }

    private static char minuscula() {
        return (char) Math.floor(Math.random() * (122 - 97 + 1) + 97);
    }

    private static int numero() {
        return (int) Math.floor(Math.random()*(9 + 1));
    }

    public String generatePass(){
        String clave =  "";
        for(int i = 1 ; i <= 5 ; i++) {
            switch((int) Math.floor(Math.random()*(3 - 1 + 1) + 1)) {
                case 1:
                    clave += mayuscula();
                    break;
                case 2:
                    clave += minuscula();
                    break;
                case 3:
                    clave += numero();
                    break;
            }
        }
        return clave;
    }
}
