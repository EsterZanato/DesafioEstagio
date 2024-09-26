
        bool[] lampadas = new bool[3]; // False = apagada, True = acesa
        bool[] quente = new bool[3];    // False = fria, True = quente

        
        Console.WriteLine("1. Ligue o primeiro interruptor e aguarde um tempo...");
        lampadas[0] = true; 

        Console.WriteLine("2. Após alguns minutos, desligue o primeiro interruptor e ligue o segundo...");
        lampadas[0] = false;
        quente[0] = true;   
        lampadas[1] = true; 

        Console.WriteLine("3. Vá até a sala das lâmpadas...");

        // Verificação do estado das lâmpadas
        for (int i = 0; i < 3; i++)
        {
            if (lampadas[i] == true)
            {
                Console.WriteLine($"A lâmpada {i + 1} está acesa e é controlada pelo interruptor {i + 1}.");
            }
            else if (quente[i] == true)
            {
                Console.WriteLine($"A lâmpada {i + 1} está apagada, mas quente, e é controlada pelo interruptor {i + 1}.");
            }
            else
            {
                Console.WriteLine($"A lâmpada {i + 1} está apagada e fria, e é controlada pelo interruptor {i + 1}.");
            }
        }
