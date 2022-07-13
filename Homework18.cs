using System;

namespace Homework18
{
    class Program
    {
        static void Main()
        {
            int playerPowerEnergy = 100;
            int playerIncreasePowerEnergy = 15;
            int playerPowerEnergyUsingHealth = 30;
            int playerPowerEnergyUsingDamage = 10;
            int playerPowerEnergyUsingShield = 30;
            int playerPowerEnergyUsingArmagedon = 90;
            int playerPowerEnergyUsingCrit = 25;
            int playerHealthStart = 1000;
            int playerHealthInGame = playerHealthStart;
            int playerHealth75Percent = 750;
            int playerHealth25Percent = 250;
            int bossHealth = 2000;
            int playerDamage;
            int bossDamage;
            int minCritChance = 3;
            int maxCritChance = 5;
            int minChanceBossCrit = 1;
            int maxChanceBossCrit = 20;
            int minPlayerDamage = 40;
            int maxPlayerDamage = 60;
            int minBossDamage = 60;
            int maxBossDamage = 100;
            int playerCritDamage;
            int bossCritDamage;
            int bossActivateCrit = 15;
            int armagedonCount = 10;
            int playerDamageArmagedon = 0;
            int playerDamageUsingArmagedon = 70;
            string userCommand;
            bool playerSpellShieldLaunch = false;
            const string playerDamageInGame = "Damage";
            const string playerSpellHealth = "Health";
            const string playerSpellCrit = "Crit";
            const string playerSpellArmagedon = "Armagedon";
            const string playerSpellShield = "Shield";
            const string playerSkipTurn = "Skip";


            while (playerHealthInGame >= 0 && bossHealth >= 0)
            {
                Random random = new Random();
                int randomCritChance = random.Next(minCritChance, maxCritChance);
                Random randomBossCrit = new Random();
                int randomChanseBossCrit = randomBossCrit.Next(minChanceBossCrit, maxChanceBossCrit);
                Random randomPlayerDamage = new Random();
                playerDamage = randomPlayerDamage.Next(minPlayerDamage, maxPlayerDamage);
                Random randomBossDamage = new Random();
                bossDamage = randomBossDamage.Next(minBossDamage, maxBossDamage);


                playerCritDamage = (playerDamage * randomCritChance);
                bossCritDamage = (bossDamage * randomCritChance);

                Console.WriteLine("Выберете действие:\n" +
                    "Damage\n" +
                    "Health\n" +
                    "Crit\n" +
                    "Armagedon\n" +
                    "Shield\n" +
                    "Skip");
                userCommand = Console.ReadLine();

                switch (userCommand)
                {
                    case playerDamageInGame:
                        if (playerPowerEnergy > playerPowerEnergyUsingDamage)
                        {
                            bossHealth -= playerDamage;
                            playerPowerEnergy -= playerPowerEnergyUsingDamage;
                        }
                        else
                        {
                            Console.WriteLine($"Вам не хватает энергии для заклинания, у вас {playerPowerEnergy} энергии.");
                            playerDamage = 0;
                        }
                        break;

                    case playerSpellHealth:
                        if (playerSpellShieldLaunch == true)
                        {
                            if(playerHealthInGame == playerHealthStart)
                            {
                                Console.WriteLine("Лечение вам не нужно!");
                            }
                            else if (playerHealthInGame <= playerHealth75Percent)
                            {
                                playerHealthInGame += playerHealth25Percent;
                                Console.WriteLine($"Игрок исцелился на {playerHealth25Percent} очков здоровья!");
                            }
                            else
                            {
                                playerHealthInGame = playerHealthStart;
                                Console.WriteLine("Игрок полностью исцелился!");
                            }
                            playerSpellShieldLaunch = false;
                            playerPowerEnergy -= playerPowerEnergyUsingHealth;
                            playerDamage = 0;
                            bossDamage = 0;
                        }
                        else
                        {
                            Console.WriteLine("Сначала активируйте заклинание Shield");
                            playerDamage = 0;
                        }
                        break;

                    case playerSpellCrit:
                        if (playerPowerEnergy > playerPowerEnergyUsingCrit)
                        {
                            bossHealth -= Convert.ToInt32(playerCritDamage);
                            playerPowerEnergy -= playerPowerEnergyUsingCrit;
                            playerDamage = playerCritDamage;
                        }
                        else
                        {
                            Console.WriteLine($"Вам не хватает энергии для заклинания, у вас {playerPowerEnergy} энергии.");
                            playerDamage = 0;
                        }
                        break;

                    case playerSpellArmagedon:
                        if (playerPowerEnergy >= playerPowerEnergyUsingArmagedon)
                        {
                            playerDamage = playerDamageUsingArmagedon;
                            for (int i = 0; i < armagedonCount; i++)
                            {
                                bossHealth -= playerDamage;
                                playerDamageArmagedon += playerDamage;
                            }
                            playerDamage = playerDamageArmagedon;
                            playerPowerEnergy -= playerPowerEnergyUsingArmagedon;
                        }
                        else
                        {
                            Console.WriteLine($"Вам не хватает энергии для заклинания,у вас {playerPowerEnergy}");
                            playerDamage = 0;
                        }
                        break;

                    case playerSpellShield:
                        if (playerPowerEnergy > playerPowerEnergyUsingShield)
                        {
                            Console.WriteLine("Игрок активировал щит!");
                            playerDamage = 0;
                            bossDamage = 0;
                            playerPowerEnergy -= playerPowerEnergyUsingShield;
                            playerSpellShieldLaunch = true;
                        }
                        else
                        {
                            Console.WriteLine($"Вам не хватает энергии для заклинания,у вас {playerPowerEnergy}");
                            playerDamage = 0;
                        }
                        break;

                    case playerSkipTurn:
                        Console.WriteLine("Игрок пропускает ход!");
                        break;
                }

                if (randomChanseBossCrit >= bossActivateCrit)
                {
                    playerHealthInGame -= bossCritDamage;
                    bossDamage = bossCritDamage;
                    Console.WriteLine("Босс нанес критический урон!");
                }
                else
                {
                    playerHealthInGame -= bossDamage;
                }

                Console.WriteLine($"Игрок наносит {playerDamage} урона боссу\n" +
                    $"Босс наносит {bossDamage} урона игроку\n" +
                    $"Здоровье игрока {playerHealthInGame}\n" +
                    $"Энергия игрока {playerPowerEnergy}\n" +
                    $"Здоровье босса {bossHealth}");
                playerPowerEnergy += playerIncreasePowerEnergy;
            }
        }
    }
}
