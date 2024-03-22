package com.example.cinetec;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class sesionScreen extends AppCompatActivity {
    EditText username;
    EditText password;

    Button login;
    Button back;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_sesion_screen);
        username = findViewById(R.id.mail);
        password = findViewById(R.id.password);
        login = findViewById(R.id.login);
    }
    public void onClickIniciarSesion(View view) {
        username.setError(null);
        username.setError(null);

        String et_user = username.getText().toString();
        String et_password = password.getText().toString();


        if (et_user.isEmpty()) {
            username.setError("Este campo no puede estar vacio"); // si está vacío el método finaliza
            return;
        }
        if (et_password.isEmpty()) {
            password.setError("Este campo no puede estar vacio");
            return;
        }
        if (et_password.equals(et_user) | et_user.equals("admin")){
            Intent intent = new Intent(this, adminView.class);
            startActivity(intent);
        }
    }
    public void onClickBack(View view){
        Intent intent = new Intent(this, MainActivity.class);
        startActivity(intent);
    }
}