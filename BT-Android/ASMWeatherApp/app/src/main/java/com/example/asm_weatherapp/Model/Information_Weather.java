package com.example.asm_weatherapp.Model;

public class Information_Weather {
    private String time;
    private String icon;
    private Temperature Temperature;

    public String getTime() {
        return time;
    }
    public void setTime(String time) {
        this.time = time;
    }

    public String getIcon() {
        return icon;
    }
    public void setIcon(String icon) {
        this.icon = icon;
    }

    public Temperature getTemperature() {
        return Temperature;
    }

    public void setTemperature(com.example.asm_weatherapp.Model.Temperature temperature) {
        Temperature = temperature;
    }
}
