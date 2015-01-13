file_name = 'Setup/BlinkStickInteropDLL.wxs'
text = File.read(file_name)
new_contents = text.gsub(/PUT\-GUID\-HERE/, "168B3856-B932-4BA9-8932-C4B2F3974327")
File.open(file_name, "w") {|file| file.puts new_contents }

file_name = 'Setup/BlinkStickInteropTLB.wxs'
text = File.read(file_name)
new_contents = text.gsub(/PUT\-GUID\-HERE/, "D5C45353-ACD5-4774-8C3B-0AD52A47D142")
File.open(file_name, "w") {|file| file.puts new_contents }

