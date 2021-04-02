package com.example.asm_weatherapp;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;
import android.widget.LinearLayout;
import android.widget.TextView;

import com.example.asm_weatherapp.Model.Information_Weather;
import com.example.asm_weatherapp.adapter.NewsAdapter;
import com.example.asm_weatherapp.network.APIWeather;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class MainActivity extends AppCompatActivity {

    private RecyclerView rvWeather;
    private TextView tvTemperature;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        tvTemperature = (TextView) findViewById(R.id.tvTemperature);

        LinearLayoutManager layoutManager = new LinearLayoutManager(this, LinearLayoutManager.HORIZONTAL, false);

        getData();
        
        rvWeather = (RecyclerView) findViewById(R.id.rvWeather);
        rvWeather.setLayoutManager(layoutManager);
    }

    private void getData() {
        Retrofit retrofit = new Retrofit.Builder()
                .baseUrl(APIWeather.SERVER_URL)
                .addConverterFactory(GsonConverterFactory.create())
                .build();

        APIWeather service = retrofit.create(APIWeather.class);

        service.getListHour().enqueue(new Callback<List<Information_Weather>>() {
            @Override
            public void onResponse(Call<List<Information_Weather>> call, Response<List<Information_Weather>> response) {
                if(response.body() == null){
                    return;
                }
                List<Information_Weather> listWeather =  response.body();
                NewsAdapter adapter = new NewsAdapter(MainActivity.this, listWeather);
                rvWeather.setAdapter(adapter);

                Information_Weather Info_Weather = listWeather.get(0);
                final float tem = Info_Weather.getTemperature().getTem();
                tvTemperature.setText((int) tem);
            }

            @Override
            public void onFailure(Call<List<Information_Weather>> call, Throwable t) {

            }
        });
    }
}