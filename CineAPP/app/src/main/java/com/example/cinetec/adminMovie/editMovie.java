package com.example.cinetec.adminMovie;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import com.example.cinetec.R;
import com.example.cinetec.confirmView;

public class editMovie extends AppCompatActivity {
    EditText OgName;
    EditText CmName;
    EditText duration;
    EditText characters;
    EditText director;
    EditText clasification;
    Button register;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_edit_movie);
        OgName = findViewById(R.id.OgName);
        CmName = findViewById(R.id.CmName);
        duration = findViewById(R.id.duration);
        characters = findViewById(R.id.characters);
        director = findViewById(R.id.director);
        clasification = findViewById(R.id.clasification);
        register = findViewById(R.id.register);
    }
    public void onClickRegister(View view){
        String Name1 = OgName.getText().toString();
        String Name2 = CmName.getText().toString();
        String time = duration.getText().toString();
        String prota = characters.getText().toString();
        String directors = director.getText().toString();
        String clas = clasification.getText().toString();

        if (Name1.isEmpty()){
            OgName.setError("Este campo no puede estar vacio");
            return;
        }
        if (Name2.isEmpty()){
            CmName.setError("Este campo no puede estar vacio");
            return;
        }
        if (time.isEmpty()){
            duration.setError("Este campo no puede estar vacio");
            return;
        }
        if (prota.isEmpty()){
            characters.setError("Este campo no puede estar vacio");
            return;
        }
        if (directors.isEmpty()){
            director.setError("Este campo no puede estar vacio");
            return;
        }
        if (clas.isEmpty()){
            clasification.setError("Este campo no puede estar vacio");
            return;
        }
        Intent intent = new Intent(this, confirmView.class);
        startActivity(intent);
    }
    public void onClickBack(View view){
        Intent intent = new Intent(this, AdminMovie.class);
        startActivity(intent);
    }
}