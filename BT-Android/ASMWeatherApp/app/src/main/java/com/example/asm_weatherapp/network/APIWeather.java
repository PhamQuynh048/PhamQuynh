package com.example.asm_weatherapp.network;


import com.example.asm_weatherapp.Model.Information_Weather;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.GET;

public interface APIWeather {
    String SERVER_URL = "https://developer.accuweather.com/";

    @GET("forecasts/v1/daily/5day/353412?apikey=wpRbEFg5OGOg8iyBLjSMsHPu5MAPrMET&language=vi-vn&metric=true")
    Call<List<Information_Weather>> getListDay();

    @GET("forecasts/v1/hourly/12hour/353412?apikey=wpRbEFg5OGOg8iyBLjSMsHPu5MAPrMET&language=vi-vn&metric=true")
    Call<List<Information_Weather>> getListHour();
}
