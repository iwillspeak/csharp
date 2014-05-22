file 'main.exe' => ['main.cs'] do
  sh "gmcs -out:main.exe main.cs"
end

task :test => 'main.exe' do
  sh 'mono main.exe'
end
