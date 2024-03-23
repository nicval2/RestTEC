package com.example.cinetec.adminSucursal;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

import com.example.cinetec.R;
import com.example.cinetec.adminView;
import com.example.cinetec.confirmView;

public class registerSucursales extends AppCompatActivity {
    EditText Iname;
    EditText ubicacion;
    EditText salas;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register_sucursales);
        Iname = (EditText) findViewById(R.id.Iname);
        ubicacion = (EditText) findViewById(R.id.ubicacion);
        salas = (EditText) findViewById(R.id.numSalas);
    }
    public void OnClickRegister(View view){
        String Name1 = Iname.getText().toString();
        String Name2 = ubicacion.getText().toString();
        String num = salas.getText().toString();
        if (Name1.isEmpty()){
            Iname.setError("Este campo no puede estar vacio");
            return;
        }
        if (Name2.isEmpty()){
            ubicacion.setError("Este campo no puede estar vacio");
            return;
        }
        if (num.isEmpty()){
            salas.setError("Este campo no puede estar vacio");
            return;
        }
        Intent intent = new Intent(this, confirmView.class);
        startActivity(intent);
    }
    public void onClickBack(View view){
        Intent intent = new Intent(this, AdminSucursal.class);
        startActivity(intent);
    }
}