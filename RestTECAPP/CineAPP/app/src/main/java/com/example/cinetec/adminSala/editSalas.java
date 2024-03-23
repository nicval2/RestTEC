package com.example.cinetec.adminSala;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

import com.example.cinetec.R;
import com.example.cinetec.confirmView;

public class editSalas extends AppCompatActivity {
    EditText id;
    EditText name;
    EditText filas;
    EditText columnas;
    EditText capacidad;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_edit_salas);
        id = (EditText) findViewById(R.id.id);
        name = (EditText) findViewById(R.id.name);
        filas = (EditText) findViewById(R.id.filas);
        columnas = (EditText) findViewById(R.id.columnas);
        capacidad = (EditText) findViewById(R.id.capacidad);
    }

    public void onClickRegister(View view) {
        String identificador = id.getText().toString();
        String sucursal = name.getText().toString();
        String row = filas.getText().toString();
        String colum = columnas.getText().toString();
        String aforum = capacidad.getText().toString();
        if (identificador.isEmpty()){
            id.setError("Este campo no puede estar vacio");
            return;
        }
        if (sucursal.isEmpty()){
            name.setError("Este campo no puede estar vacio");
            return;
        }
        if (row.isEmpty()){
            filas.setError("Este campo no puede estar vacio");
            return;
        }
        if (colum.isEmpty()){
            columnas.setError("Este campo no puede estar vacio");
            return;
        }
        if (aforum.isEmpty()){
            capacidad.setError("Este campo no puede estar vacio");
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