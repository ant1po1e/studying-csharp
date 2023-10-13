read -p "File Name: " file

mcs -out:./$file.exe ./$file.cs
