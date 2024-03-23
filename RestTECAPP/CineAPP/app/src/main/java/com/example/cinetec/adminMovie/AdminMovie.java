package com.example.cinetec.adminMovie;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import com.example.cinetec.R;
import com.example.cinetec.adminView;

public class AdminMovie extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_admin_movie);
    }

    public void onClickRegister(View view) {
        Intent intent = new Intent(this, registerMovies.class);
        startActivity(intent);
    }
    public void onClickEdit(View view) {
        Intent intent = new Intent(this, editMovie.class);
        startActivity(intent);
    }
    public void onClickDelete(View view){
        Intent intent = new Intent(this, deleteMovie.class);
        startActivity(intent);
    }
    public void onClickConsult(View view){
        Intent intent = new Intent(this, consultMovie.class);
        startActivity(intent);
    }

    public void onClickBack(View view) {
        Intent intent = new Intent(this, adminView.class);
        startActivity(intent);
    }
}