package com.example.cinetec.adminSala;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import com.example.cinetec.R;
import com.example.cinetec.adminView;

public class AdminSalas extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_admin_salas);
    }

    public void onClickRegister(View view) {
        Intent intent = new Intent(this, registerSalas.class);
        startActivity(intent);
    }

    public void onClickEdit(View view) {
        Intent intent = new Intent(this, editSalas.class);
        startActivity(intent);
    }

    public void onClickDelete(View view) {
        Intent intent = new Intent(this, deleteSalas.class);
        startActivity(intent);
    }

    public void onClickConsult(View view) {
        Intent intent = new Intent(this, consultSalas.class);
        startActivity(intent);
    }

    public void onClickBack(View view) {
        Intent intent =  new Intent(this, adminView.class);
        startActivity(intent);
    }
}