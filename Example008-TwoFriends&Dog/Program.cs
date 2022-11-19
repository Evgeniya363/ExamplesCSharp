// Two friends and the dog
int speedFirstFriend=1000,
    speedSecondFriend=2000,
    speedDog=5000, Friend=2,
    count=0;
double distance=10000, time = 0;
  
while(distance>1)
{
  if(Friend==1)
  {
    time = distance / (speedSecondFriend + speedDog);
    Friend=2;
  }
  else
  {
    time = distance / (speedFirstFriend + speedDog);
    Friend=1;
  }
  distance = distance-time*(speedFirstFriend+speedSecondFriend);
  count++;
}

Console.WriteLine("Собака пробежала (раз): "+count);
