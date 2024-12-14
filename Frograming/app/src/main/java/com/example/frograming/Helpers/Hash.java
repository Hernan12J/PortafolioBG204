package com.example.frograming.Helpers;

import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;

public class Hash {

    private String s;

    public Hash(String s) {
        this.s = s;
    }

    public String tomd5() {
        try {
            // Create MD5 Hash
            MessageDigest digest = java.security.MessageDigest.getInstance("MD5");
            digest.update(s.getBytes());
            byte messageDigest[] = digest.digest();

            // Create Hex String
            StringBuffer hexString = new StringBuffer();
            for (int i=0; i<messageDigest.length; i++)
                hexString.append(Integer.toHexString(0xFF & messageDigest[i]));

            String hex = hexString.toString();

            return hex;
        }catch (NoSuchAlgorithmException e) {
            e.printStackTrace();
        }
        return "";
    }
}
