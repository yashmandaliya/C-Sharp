# 1) Program To Perform Auto Textbox With PopUp Menu In C#
```
            SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");
            cn.Open();
            string sql = "insert into Table1 values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')";
            SqlCommand cmd = new SqlCommand(sql,cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your Data Is Inserted");
            cn.Close();       
```

## Output:-

# Step:-1
## Create Database...
![Data](https://user-images.githubusercontent.com/112624754/218632189-8c0e5508-98f3-432a-8d39-5dc1a72387b2.png)
# Step:-2
## Write Code..
![Main2](https://user-images.githubusercontent.com/112624754/218632249-2f205112-1496-4c55-b1a4-a4280a80f2c5.png)
# Step:-3
## Create View..
![Main](https://user-images.githubusercontent.com/112624754/218632386-b24f4a08-b27d-4efc-8627-6e18a6149f40.png)
# Step:-4
## Change In TextBox Property
```
1) AutoCompleteCollectionSource :- Input Country,City,State Names..
2) AutoCompleteMode   :- Suggest
3) AutoCompleteSource :- Custom Source
```
![Pro1](https://user-images.githubusercontent.com/112624754/218632415-4dc2a4b3-5bd1-47d2-9840-c3774cfff683.png)
# Step:-5
## Input Those names
![Pro2](https://user-images.githubusercontent.com/112624754/218632429-f27bd5dc-57ec-46a3-aa38-f478ac77aa66.png)
# Step:-6 
## Output 1
![Out](https://user-images.githubusercontent.com/112624754/218632437-f71332da-56e6-4637-8fbf-0968afc14eea.png)
## Output 2
![Out2](https://user-images.githubusercontent.com/112624754/218632442-f9a646da-8131-4849-aa8d-00607807d0d8.png)

