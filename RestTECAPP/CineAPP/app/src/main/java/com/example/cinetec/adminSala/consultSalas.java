package com.example.cinetec.adminSala;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

import com.example.cinetec.R;
import com.example.cinetec.confirmView;

public class consultSalas extends AppCompatActivity {
    EditText id;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_consult_salas);
        id = (EditText) findViewById(R.id.id);
    }

    public void onClickRegister(View view) {
        String newId = id.getText().toString();

        if(newId.isEmpty()){
            id.setError("Este campo no puede estar vacio");
            return;
        }
        Intent intent = new Intent(this, confirmView.class);
        startActivity(intent);
    }

    public void onClickBack(View view) {
        Intent intent = new Intent(this, AdminSalas.class);
        startActivity(intent);
    }
}