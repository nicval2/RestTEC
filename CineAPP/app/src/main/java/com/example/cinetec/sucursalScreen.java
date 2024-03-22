package com.example.cinetec;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class sucursalScreen extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_sucursal_screen);
    }
    public void onClickBack(View view){
        Intent intent = new Intent(this, MainActivity.class);
        startActivity(intent);

    }
}