package com.example.cinetec.adminProcc;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

import com.example.cinetec.R;
import com.example.cinetec.adminView;
import com.example.cinetec.confirmView;

public class registerProcc extends AppCompatActivity {
    EditText fecha;
    EditText hora;
    EditText sala;
    EditText pelicula;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register_procc);
        hora = (EditText) findViewById(R.id.hora);
        fecha = (EditText) findViewById(R.id.fecha);
        sala = (EditText) findViewById(R.id.sala);
        pelicula = (EditText) findViewById(R.id.pelicula);
    }

    public void onClickRegister(View view) {
        String time = hora.getText().toString();
        String date = fecha.getText().toString();
        String room = sala.getText().toString();
        String movie = pelicula.getText().toString();

        if(time.isEmpty()){
            hora.setError("Este campo no puede estar vacio");
            return;
        }
        if(date.isEmpty()){
            fecha.setError("Este campo no puede estar vacio");
            return;
        }
        if(room.isEmpty()){
            sala.setError("Este campo no puede estar vacio");
            return;
        }
        if(movie.isEmpty()){
            pelicula.setError("Este campo no puede estar vacio");
            return;
        }
        Intent intent = new Intent(this, confirmView.class);
        startActivity(intent);
    }

    public void onClickBack(View view) {
        Intent intent = new Intent(this, AdminProcc.class);
        startActivity(intent);
    }
}
