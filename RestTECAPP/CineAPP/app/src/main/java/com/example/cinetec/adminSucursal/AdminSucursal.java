package com.example.cinetec.adminSucursal;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import com.example.cinetec.R;
import com.example.cinetec.adminView;

public class AdminSucursal extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_admin_sucursal);
    }

    public void onClickRegister(View view) {
        Intent intent = new Intent(this, registerSucursales.class);
        startActivity(intent);
    }

    public void onClickEdit(View view) {
        Intent intent = new Intent(this, editSucursal.class);
        startActivity(intent);
    }

    public void onClickDelete(View view) {
        Intent intent = new Intent(this, deleteSucursal.class);
        startActivity(intent);
    }

    public void onClickConsult(View view) {
        Intent intent = new Intent(this, consultSucursal.class);
        startActivity(intent);
    }

    public void onClickBack(View view) {
        Intent intent = new Intent(this, adminView.class);
        startActivity(intent);
    }
}