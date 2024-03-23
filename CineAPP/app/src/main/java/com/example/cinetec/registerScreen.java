package com.example.cinetec;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import androidx.appcompat.app.AppCompatActivity;

import com.example.cinetec.adminMovie.AdminMovie;
import com.example.cinetec.adminMovie.AdminMovie;

public class registerScreen extends AppCompatActivity {
    EditText cedula;
    EditText Nombre;
    EditText Apellidos;
    EditText direccion;
    EditText fechadenacimiento;
    EditText telefonos;
    EditText email;
    EditText password;
    Button register;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register);

        cedula = findViewById(R.id.cedula);
        Nombre = findViewById(R.id.Nombre);
        Apellidos = findViewById(R.id.Apellidos);
        direccion = findViewById(R.id.direccion);
        fechadenacimiento = findViewById(R.id.fechadenacimiento);
        telefonos = findViewById(R.id.telefonos);
        email = findViewById(R.id.email);
        password = findViewById(R.id.password);
        register = findViewById(R.id.register);
    }
    public void onClickRegister(View view){
        cedula.setError(null);
        Nombre.setError(null);

        String Cedula = cedula.getText().toString();
        String nombre = Nombre.getText().toString();
        String apellidos = Apellidos.getText().toString();
        String Direccion = direccion.getText().toString();
        String Fechadenacimiento = fechadenacimiento.getText().toString();
        String Telefonos = telefonos.getText().toString();
        String Email = email.getText().toString();
        String Password = password.getText().toString();

        if (Cedula.isEmpty()){
            cedula.setError("Este campo no puede estar vacio");
            return;
        }
        if (nombre.isEmpty()){
            Nombre.setError("Este campo no puede estar vacio");
            return;
        }
        if (apellidos.isEmpty()){
            Apellidos.setError("Este campo no puede estar vacio");
            return;
        }
        if (Direccion.isEmpty()){
            direccion.setError("Este campo no puede estar vacio");
            return;
        }
        if (Fechadenacimiento.isEmpty()){
            fechadenacimiento.setError("Este campo no puede estar vacio");
            return;
        }
        if (Telefonos.isEmpty()){
            telefonos.setError("Este campo no puede estar vacio");
            return;
        }
        if (Email.isEmpty()){
            email.setError("Este campo no puede estar vacio");
            return;
        }
        if (Password.isEmpty()){
            password.setError("Este campo no puede estar vacio");
            return;
        }
        Intent intent = new Intent(this, confirmView.class);
        startActivity(intent);
    }
    public void onClickBack(View view){
        Intent intent = new Intent(this, MainActivity.class);
        startActivity(intent);
    }
}