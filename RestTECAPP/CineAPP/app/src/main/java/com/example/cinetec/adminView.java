package com.example.cinetec;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import com.example.cinetec.adminMovie.AdminMovie;
import com.example.cinetec.adminProcc.AdminProcc;
import com.example.cinetec.adminSala.AdminSalas;
import com.example.cinetec.adminSucursal.AdminSucursal;


public class adminView extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_admin_view);
    }
    public void onCLickRpeliculas(View view){
        Intent intent = new Intent(this, AdminMovie.class);
        startActivity(intent);
    }
    public void onCLickRsucursales(View view) {
        Intent intent = new Intent(this, AdminSucursal.class);
        startActivity(intent);
    }
    public void onCLickRsalas(View view) {
        Intent intent = new Intent(this, AdminSalas.class);
        startActivity(intent);
    }
    public void onCLickAsigProcc(View view) {
        Intent intent = new Intent(this, AdminProcc.class);
        startActivity(intent);
    }

    public void onClickBack(View view) {
        Intent intent = new Intent(this, MainActivity.class);
        startActivity(intent);
    }
}