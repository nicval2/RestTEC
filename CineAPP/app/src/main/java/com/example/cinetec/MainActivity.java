package com.example.cinetec;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    Button iniciarSesion;
    Button resgistrarse;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        iniciarSesion =findViewById(R.id.iniciarSesion);
        resgistrarse = findViewById(R.id.register);
    }

    public void onClickInSesion(View view){
        Intent intent = new Intent(this, sesionScreen.class);
        startActivity(intent);
    }
    public void onClickRegistro(View view){
        Intent intent = new Intent(this, registerScreen.class);
        startActivity(intent);
    }
}