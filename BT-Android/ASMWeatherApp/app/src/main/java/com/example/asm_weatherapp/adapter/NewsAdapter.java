package com.example.asm_weatherapp.adapter;

import android.app.Activity;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.bumptech.glide.Glide;
import com.example.asm_weatherapp.Model.Information_Weather;
import com.example.asm_weatherapp.Model.Temperature;
import com.example.asm_weatherapp.R;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;
import java.util.SimpleTimeZone;

public class NewsAdapter extends RecyclerView.Adapter {

    private Activity activity;
    private List<Information_Weather> listWeather;

    public NewsAdapter(Activity activity, List<Information_Weather> listWeather){
        this.activity = activity;
        this.listWeather = listWeather;
    }

    @NonNull
    @Override
    public RecyclerView.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        LayoutInflater inflater = activity.getLayoutInflater();
        View view = inflater.inflate(R.layout.item_news, parent, false);
        NewsHolder holder = new NewsHolder(view);
        return holder;
    }

    @Override
    public void onBindViewHolder(@NonNull RecyclerView.ViewHolder holder, int position) {
        NewsHolder newsHolder = (NewsHolder) holder;
        Information_Weather weather = listWeather.get(position);
        newsHolder.tvHour.setText(weather.getTemperature().getTem()+"");
        String url="";
        if (weather.getIcon() >= 10) {
            url = "http://developer.accuweather.com/sites/default/files/" + weather.getIcon();
        } else {
            url = "http://developer.accuweather.com/sites/default/files/0" + weather.getIcon();
        }
        Glide.with(activity).load(url).into(newsHolder.ivCover);
    }

    @Override
    public int getItemCount() {
        return listWeather.size();
    }
    public static class NewsHolder extends RecyclerView.ViewHolder{

        private TextView tvHour, tvTemperature;
        private ImageView ivCover;

        public NewsHolder(View view) {
            super(view);
            tvHour = (TextView) view.findViewById(R.id.tvHour);
            ivCover = (ImageView) view.findViewById(R.id.ivCover);
            tvTemperature = (TextView) view.findViewById(R.id.tvTemperature);
        }
    }

    public String convertTime(String inputTime){
        SimpleDateFormat inFormat = new SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ss");
        Date date = null;
        try{
            date = inFormat.parse(inputTime);
        }catch (ParseException e){ e.printStackTrace();}
        SimpleDateFormat outFomat = new SimpleDateFormat("ha");
        String goal = outFomat.format(date);
        return  goal;
    }
}
