package com.example.cinetec;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    Button sucursal;
    Button iniciarSesion;
    Button peliculas;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        sucursal =findViewById(R.id.sucursal);
        iniciarSesion =findViewById(R.id.iniciarSesion);
        peliculas =findViewById(R.id.peliculas);
    }
    public void onClickSucursal(View view){
        Intent intent = new Intent(this, sucursalScreen.class);
        startActivity(intent);
    }
    public void onClickInSesion(View view){
        Intent intent = new Intent(this, sesionScreen.class);
        startActivity(intent);
    }
    public void onClickPelicuas(View view){
        Intent intent = new Intent(this, peliculasScreen.class);
        startActivity(intent);
    }
}